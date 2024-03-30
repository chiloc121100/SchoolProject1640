using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SchoolProject1640.Data;
using SchoolProject1640.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SchoolProject1640.Hubs
{
    public class ChatHub : Hub
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ChatHub(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task SendMessage(string articleId, string message)
        {
            var user = await _userManager.GetUserAsync(Context.User);

            var newMessage = new Message
            {
                AccountID = user.Id,
                ArtID = int.Parse(articleId),
                Mess = message
            };
            _context.Add(newMessage);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

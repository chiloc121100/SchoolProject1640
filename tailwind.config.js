/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Views/**/*.cshtml"],
  theme: {
    extend: {},
  },
    plugins: [],
    variants: {
        extend: {
            backgroundColor: ['hover', 'focus'],
            textColor: ['hover', 'focus'],
            // Add other states as needed
        },
    },
}


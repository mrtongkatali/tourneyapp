/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Views/**/*.cshtml', // Razor Views
    './wwwroot/**/*.html', // Static HTML files (if any)
    './Pages/**/*.cshtml', // For Razor Pages
  ],
  theme: {
    extend: {},
  },
  plugins: [
    require('@tailwindcss/forms'),
    require('@tailwindcss/typography'),
  ],
}
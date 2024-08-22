import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";

export default defineConfig({
  plugins: [react()],
  server: {
    proxy: {
      "/register": {
        target: "https://localhost:7265",
        changeOrigin: true,
        secure: false,
      },
    },
  },
});

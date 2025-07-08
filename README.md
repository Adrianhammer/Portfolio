# 💼 Portfolio

> A modern, responsive portfolio website built with ASP.NET Core Razor Pages, featuring automated CI/CD deployment to a self-hosted Proxmox environment.

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/Adrianhammer/Portfolio) [![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://claude.ai/chat/LICENSE) [![.NET](https://img.shields.io/badge/.NET-Core-purple)](https://dotnet.microsoft.com/) [![Proxmox](https://img.shields.io/badge/Deployed%20on-Proxmox-orange)](https://www.proxmox.com/)

## 🌟 Features

- **Modern Design**: Clean, responsive UI built with Razor Pages
- **Automated Deployment**: GitHub Actions CI/CD pipeline with self-hosted runners
- **Self-Hosted Infrastructure**: Deployed on Proxmox containers for full control
- **Performance Optimized**: Fast loading times and smooth user experience

## 🏗️ Architecture & Infrastructure

### Technology Stack

- **Frontend**: ASP.NET Core Razor Pages
- **Backend**: C# / .NET Core
- **Hosting**: Self-hosted on Proxmox VE
- **CI/CD**: GitHub Actions with runners
- **Containerization**: Linux containers (CT) on Proxmox

### DevOps Pipeline

```
GitHub Push → GitHub Actions → Self-hosted Runner (Proxmox CT) → Container Update
```

The deployment process is fully automated:

1. **Code Push**: Push to `main` branch triggers the pipeline
2. **GitHub Runner**: Running on Proxmox container picks up the job
3. **Automated Deployment**: Runner updates the application container with minimal downtime (too lazy to fix zero downtime)
4. **Live Update**: Changes are immediately available on the live site

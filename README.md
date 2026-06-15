<div align="center">

<img src="https://img.shields.io/badge/DSH%20Hacks%20V1-AI%20×%20STEM%20Education-6366f1?style=for-the-badge" />

# 🚀 STEMPilot AI

**An interactive STEM learning platform that helps students find what they don't know — and fix it.**

[![React](https://img.shields.io/badge/React.js-20232A?style=flat-square&logo=react&logoColor=61DAFB)](https://reactjs.org/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/en-us/sql-server)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://learn.microsoft.com/en-us/ef/core/)

</div>

---

## 📌 The Problem

Most students study STEM subjects without ever knowing where their actual gaps are. Traditional quizzes give a score and move on — no breakdown, no history, no sense of whether you're improving or just repeating the same mistakes.

The result: students waste time studying what they already know, and never confront what they don't.

---

## 💡 What STEMPilot AI Does

STEMPilot AI is a quiz-based assessment platform built for STEM students. You log in, pick a subject, answer questions, and immediately see how you did. More importantly, the platform tracks every attempt — so over time, you can see your average score, your best performance, your worst, and how much you've actually improved.

It turns passive studying into something measurable.

---

## ✨ Features

### 🔐 Authentication
- Secure login and student account management

### 📚 Subject Selection
- Multiple STEM subjects available
- Clean selection interface before each quiz session

### 🧠 Quiz Engine
- Interactive multiple-choice questions
- Real-time answer submission with instant evaluation

### ✅ Automatic Scoring
- Answers evaluated immediately on submission
- Percentage-based score calculation per attempt

### 📊 Dashboard Analytics
Every student gets a personal dashboard showing:
| Metric | Description |
|---|---|
| Total Attempts | How many quizzes completed |
| Average Score | Performance across all attempts |
| Best Score | Personal best for motivation |
| Worst Score | Identifies the subjects needing work |

### 🗂️ Quiz History
- Full record of previous attempts
- Lets students track improvement over specific subjects

---

## 🏗️ Architecture

```
Student
  └── React Frontend (React Router DOM + Axios)
        └── ASP.NET Core Web API (C#)
              └── Entity Framework Core
                    └── SQL Server
```

---

## 🔄 How It Works

```
1. Student logs in
2. Dashboard loads — shows all historical stats
3. Student selects a subject
4. Quiz questions load dynamically from the database
5. Student submits answers
6. Backend evaluates responses instantly
7. Score is calculated and stored
8. Dashboard updates with the new attempt
```

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Frontend | React.js, React Router DOM, Axios |
| Backend | ASP.NET Core Web API (C#) |
| Database | SQL Server |
| ORM | Entity Framework Core |

---

## 🚀 Getting Started

### Prerequisites
- Node.js (v18+)
- .NET 8 SDK
- SQL Server (local or remote instance)

### Backend Setup

```bash
# Clone the repository
git clone https://github.com/your-username/stempilot-ai.git
cd stempilot-ai/backend

# Update connection string in appsettings.json
# Then run migrations
dotnet ef database update

# Start the API
dotnet run
```

### Frontend Setup

```bash
cd ../frontend

# Install dependencies
npm install

# Start the dev server
npm run dev
```

> Update the API base URL in your Axios config to match the backend port before running.

---

## 🔮 Planned Enhancements

These didn't make the hackathon deadline, but they're the natural next step:

- **AI-powered recommendations** — suggest which subjects and topics to focus on next based on score history
- **Adaptive difficulty** — questions that get harder or easier based on performance
- **Learning path generation** — structured paths per subject from weak to strong
- **Gamification** — streaks, badges, and achievement tracking
- **Advanced analytics** — per-topic breakdown, not just per-quiz

---

## 👨‍💻 Authors

Built for **DSH Hacks V1 — AI × STEM Education Hackathon**

| Name | Role |
|---|---|
| Sanan Malik | Backend — ASP.NET Core Web API, Database Design |
| [Co-author] | [Role] |

---

## 📄 License

This project was built for a hackathon. Feel free to reference or build on it.

---

<div align="center">
  <sub>Built with React · ASP.NET Core · SQL Server · Entity Framework Core</sub>
</div>

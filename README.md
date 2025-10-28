# 🎮 C# Game Collection — Windows Forms Edition

A desktop application developed in **C# using Windows Forms**, featuring three interactive games:
- 🎱 **Bingo**
- 🎰 **Casino Roulette**
- 💰 **Who Wants to Be a Millionaire**

The project combines game logic, graphical interface design, and event-driven programming.  
It provides a fun and educational way to explore **C#**, **Windows Forms**, and **object-oriented programming** concepts.

---

## 🕹️ Games Overview

### 🎱 Bingo
- Random number generation between 1–75  
- Dynamic card generation with randomized layouts  
- Real-time display of drawn numbers  
- Automatic detection of completed rows or full Bingo  

### 🎰 Casino Roulette
- Simulates a classic roulette table  
- Player bets on:
  - Color (Red/Black)  
  - Number  
  - Even/Odd  
- Automatic win/loss calculation  

### 💰 Who Wants to Be a Millionaire
- Multiple-choice trivia game  
- Increasing prize tiers  
- Visual interface with buttons for each question  
- Optional lifelines such as *50/50* or *Skip Question*  

---

## 🧩 Project Structure

csharp-game-collection/
├── BingoForm.cs # Bingo interface and logic
├── RouletteForm.cs # Casino Roulette interface and logic
├── MillionaireForm.cs # Quiz game interface and logic
├── MainMenuForm.cs # Main navigation menu
├── Program.cs # Entry point
├── Properties/ # App configuration and resources
├── Resources/ # Images, sounds, and icons
├── bin/ # Compiled files
├── obj/ # Build artifacts
└── README.md


---

## 🛠️ Technologies Used

| Technology | Description |
|-------------|-------------|
| **C# (.NET 6 or later)** | Core programming language |
| **Windows Forms** | Graphical user interface framework |
| **System.Random** | Random number generation for game logic |
| **OOP (Object-Oriented Programming)** | Modular design — one class/form per game |

---

## 🚀 How to Run

1. **Prerequisites**
   - Install **Visual Studio 2022** or newer  
   - Ensure the **.NET Desktop Development** workload is installed  

2. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/csharp-game-collection.git
   cd csharp-game-collection

    Open the project

        Open the .sln file in Visual Studio

    Run the application

        Press F5 or click Start to build and run the program

🧭 Project Goal

The purpose of this project is to demonstrate:

    Use of Windows Forms for GUI applications

    Application of C# logic in an interactive environment

    Modular design and event-driven programming

    Integration of randomness and probability in games

It serves as both a learning tool and a fun example of desktop game development.
🔮 Future Improvements

    Add score tracking across sessions

    Include sound effects and background music

    Add difficulty levels for each game

    Improve layout with responsive design

    Create a leaderboard using local file storage

# 🎮 C# Game Collection

A console-based project developed in **C#**, featuring three interactive mini-games:
- 🎱 **Bingo**
- 🎰 **Casino Roulette**
- 💰 **Who Wants to Be a Millionaire**

Each game is designed to demonstrate programming logic, randomness, user interaction, and basic control structures in C#.  
The program provides a simple and entertaining way to explore fundamental programming concepts while simulating real-life games.

---

## 🕹️ Games Overview

### 🎱 Bingo
- Random number generation between 1–75  
- Dynamic card creation  
- Displays drawn numbers and player matches  
- Detects when the player completes a line or full card (Bingo!)

### 🎰 Casino Roulette
- Simulates a real roulette wheel  
- Player chooses a bet type:
  - Color (Red/Black)
  - Number
  - Even/Odd
- Random spin with automatic win/loss calculation

### 💰 Who Wants to Be a Millionaire
- Multiple-choice trivia game  
- Progressive prize levels  
- Instant feedback for each answer  
- Simulates lifelines such as *50/50* or *Skip Question* (optional)  

---

## 🧩 Project Structure

csharp-game-collection/
├── Program.cs # Main menu and navigation
├── Bingo.cs # Bingo logic
├── Roulette.cs # Casino roulette logic
├── Millionaire.cs # Quiz game logic
├── bin/ # Compiled binaries
├── obj/ # Build artifacts
└── README.md


---

## ⚙️ Technologies Used

| Technology | Description |
|-------------|-------------|
| **C# (.NET 6 or later)** | Core programming language |
| **System.Random** | Used for random number generation |
| **Console Application** | Text-based interface |
| **Object-Oriented Design** | Each game built as a separate class |

---

## 🚀 How to Run

1. **Prerequisites**
   - .NET SDK **6.0** or higher installed  
   - A code editor such as **Visual Studio** or **Visual Studio Code**

2. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/csharp-game-collection.git
   cd csharp-game-collection

    Run the application

    dotnet run

🧠 Example Output

=============================
🎮 C# Game Collection
=============================
1. Bingo
2. Casino Roulette
3. Who Wants to Be a Millionaire
4. Exit
=============================
Choose a game: 2
🎰 Spinning the wheel...
Result: 17 (Red)
You bet on Black. You lose!

🧭 Project Goal

This project was developed to demonstrate:

    Control structures and loops

    Randomization and probability logic

    Modular code organization using C# classes

    User interaction via the console

It serves as both a learning project and a fun demonstration of logic-based game design.

Console Card Game - Logic & Implementation
A robust C# implementation for a multi-player card game, focusing on clean, scalable data management and automated winner evaluation.

📝 Overview
This application performs standard deck operations—shuffling, dealing, and card flipping—and includes a custom evaluation algorithm to determine the winner based on card rank. Designed as a modular console utility, it prioritizes maintainability and logical separation over hard-coded solutions.

⚙️ Technical Implementation
The project demonstrates a transition from manual variable tracking to a collection-based architectural pattern.

Key Structural Improvements
Data Organization: Replaced hard-coded variables (e.g., p1_card1) with a List<Card>[] structure. This ensures that card data is grouped logically and accessed iteratively.

Algorithmic Winner Detection: Implemented nested for and foreach loops to scan player hands. This decouples the game logic from specific player counts, allowing the system to scale without code modification.

Centralized Logic: Utilized a helper function (RankValue) to encapsulate card ranking logic, adhering to the DRY (Don't Repeat Yourself) principle.

💻 Tech Stack
Language: C#

IDE: Visual Studio

Core Concepts: Collections, Nested Iteration, State Management, and Encapsulation.

🚀 How to Run
Clone this repository to your local machine.

Open the project in Visual Studio.

In Solution Explorer, ensure the project is set as the Startup Project.

Run the application to initiate the deal and evaluate the winner.

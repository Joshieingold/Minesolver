# Minesolver
A Windows desktop application that **automatically solves Minesweeper games** by **reading the screen and controlling the mouse**, powered by a WinUI 3 interface and a reusable C# class library.
---
##  Overview
This project demonstrates how to:

* Analyze a running Minesweeper game **purely from screen pixels**
* Determine safe moves and mine locations
* Control the mouse to play the game automatically
* Separate **UI**, **logic**, and **automation** using a clean architecture

The application does **not** hook into Minesweeper’s memory or modify the game.
It behaves like a human player — by looking at the screen and clicking the mouse.

---

## Architecture

The solution consists of two projects:

### 1. **MinesolverLibrary** (Class Library)

Responsible for all core logic:

* Screen capture & tile detection
* Board state representation
* Solver algorithms (probability & deterministic logic)
* Mouse automation logic (clicking / flagging)

This project is UI-agnostic and can be reused in other frontends.

---

### 2. **MinesolverUI** (WinUI 3 App)

Responsible for:

* User interface
* Starting / stopping the solver
* Displaying solver state and logs
* Configuration (speed, delay, debug overlays, etc.)

---

## How It Works

1. **Screen Capture**

   * Captures the Minesweeper game window or screen region
   * Identifies tiles using pixel color patterns

2. **Board Interpretation**

   * Converts pixels into a logical board model
   * Detects numbers, hidden tiles, flags, and revealed spaces

3. **Solver Logic**

   * Applies classic Minesweeper solving rules:

     * Safe tile detection
     * Guaranteed mine identification
     * Probability-based decisions when needed

4. **Mouse Control**

   * Uses Windows input APIs to:

     * Left-click safe tiles
     * Right-click suspected mines

---

## Getting Started

1. Clone the repository
2. Open the solution in **Visual Studio 2022**
3. Ensure both projects target:

   ```xml
   net8.0-windows10.0.19041.0
   ```
4. Build the solution
5. Launch the WinUI project
6. Open Minesweeper
7. Enter your setup configuration
8. Start the solver

---

## Educational Goals

This project explores:

* Screen scraping & image analysis
* Desktop automation
* WinUI 3 application design
* Separation of concerns via class libraries
* AI-style problem solving in constrained environments

---


## Future Improvements

* Project is not in working condition yet :)

---

## License

MIT License


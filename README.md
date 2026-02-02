Computational Logic & C# Implementation

The 15-Year Architecture Bridge

Overview

This repository serves as a professional portfolio documenting my transition from 15 years of conceptual systems modeling to active C#/.NET development. Rather than just "solving puzzles," these projects demonstrate my ability to translate complex mental models into clean, idiomatic, and performant code.

Core Philosophy: Logic-First Engineering

I approach software through the lens of Language Agnosticism. To me, syntax is a tool, but logic is the truth. My development style focuses on:

Defensive Programming: Using guard clauses to protect system state.
Expression-Bodied Logic: Leveraging modern C# syntax to reduce boilerplate and highlight mathematical transformations.
Bijective Mapping & Patterns: Solving problems like "Isomorphic Strings" or "Happy Numbers" using O(1) space complexity wherever possible.

Key Implementations & Logic Studies

1. System Integrity: Two-Phase Banking Logic
The Problem: Ensuring data consistency during financial transfers.
The Logic: Implementing a "Pending-to-Reconciled" state machine (Event Sourcing) to prevent data loss during concurrent transactions.
Implementation: [Link to Code]

2. String Sanitization: The "Squeaky Clean" Engine
The Problem: Complex string filtering including UTF-16/Unicode range exclusions (e.g., lowercase Greek characters).
The Logic: Utilizing LINQ and bitmask-style range checks to create a non-destructive transformation pipeline.
Implementation: [Link to Code]

3. Algorithmic Efficiency: The "Happy Number" Cycle
The Problem: Detecting infinite loops in mathematical sequences.
The Logic: Comparing HashSet tracking vs. Floyd’s Cycle-Finding Algorithm (Tortoise and Hare) to optimize memory usage.
Implementation: [Link to Code]

Technical Stack
Language: C# 12.0+ (.NET 8.0)
Frameworks: LINQ, Regex, System.Text
Methodologies: TDD (Test Driven Development) via Exercism, SOLID Principles, DRY.
Future Roadmap
I am currently expanding this portfolio into ASP.NET Core to bridge backend logic with web-scale interfaces, specifically focusing on Dependency Injection and Middleware architecture.

“Syntax can be learned in a month; architectural intuition takes a decade. I have both.”

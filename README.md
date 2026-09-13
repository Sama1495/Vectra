# 🚀 Vectra — VT-Shooter

<p align="center">
  <strong>An immersive 3D / VR arcade shooter inspired by the golden age of classic space shooters.</strong>
</p>

<p align="center">
  Built with <strong>Unity</strong>, <strong>C#</strong> and the <strong>XR Interaction Toolkit</strong>.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-Game%20Engine-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity">
  <img src="https://img.shields.io/badge/C%23-Programming-512BD4?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/XR-Virtual%20Reality-7C3AED?style=for-the-badge" alt="XR">
  <img src="https://img.shields.io/badge/Git-Version%20Control-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git">
  <img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub">
</p>

---

## 🎮 About Vectra

**Vectra**, also known as **VT-Shooter**, is a fast-paced **3D / Virtual Reality arcade shooter** inspired by the gameplay principles of legendary space shooters such as *Galaga*.

The project takes the simplicity and intensity of classic arcade combat and transforms it into a modern immersive experience where the player must react quickly, aim accurately and survive increasingly aggressive waves of enemies.

Armed with **binary blasters**, the player faces enemy formations generated dynamically throughout the match. As time progresses, enemy pressure increases, forcing the player to improve their positioning, reaction speed and accuracy.

Each game session is designed to be short, competitive and replayable, with a strong focus on achieving the highest possible score before the timer reaches zero.

---

## 🎯 Game Objective

The objective is simple:

> **Destroy as many enemies as possible before the 100-second round ends.**

The player must:

* 🎯 Aim accurately.
* 🔫 Use both blasters effectively.
* 👾 Eliminate incoming enemy formations.
* ⚡ React to increasingly frequent enemy spawns.
* 🏆 Maximize the final score before time expires.

The increasing difficulty creates a gameplay loop where every second becomes more intense than the previous one.

---

## ✨ Key Features

### 🕹️ Classic Arcade Gameplay

Vectra recreates the core philosophy of classic arcade shooters while adapting it to a modern **3D / VR environment**.

The gameplay emphasizes:

* Fast reactions
* Simple mechanics
* Increasing difficulty
* Score optimization
* Short and replayable matches

---

### 🔫 Binary Blasters

The player has access to a **dual-weapon system**, allowing both blasters to be used during combat.

This mechanic provides:

* Faster target acquisition
* Independent aiming
* Increased firing flexibility
* More dynamic VR interaction

---

### 👾 Dynamic Enemy Spawning

Enemies are generated using a dedicated spawning system.

The enemy spawner controls elements such as:

* Spawn frequency
* Enemy positioning
* Formation behavior
* Difficulty progression
* Combat intensity

As the round progresses, enemies appear more aggressively, increasing the pressure on the player.

---

### 📈 Progressive Difficulty

Vectra is designed around a progressively increasing challenge.

The longer the player survives, the more intense the match becomes.

This progression can affect:

* Enemy spawn rate
* Number of enemies
* Enemy movement
* Attack pressure
* Required player reaction speed

The result is a gameplay loop that continuously escalates until the round ends.

---

### ⏱️ 100-Second Arcade Rounds

Each match lasts approximately:

```text
100 seconds
```

This short session format creates:

* Immediate action
* Minimal downtime
* High replayability
* Competitive scoring
* Arcade-style gameplay

The goal is not simply to survive — it is to **maximize performance during a limited amount of time**.

---

### 🥽 Immersive XR Experience

Vectra uses Unity's **XR Interaction Toolkit** to provide an immersive VR interaction model.

The XR architecture enables integration with:

* VR controllers
* XR input systems
* Motion-based aiming
* Interactive weapons
* XR-ready player interaction

---

## 🧠 Game Architecture

The project follows a modular Unity architecture where each component has a clearly defined responsibility.

```text
Player Input
     │
     ▼
    Gun
     │
     ▼
   Bullet
     │
     ▼
   Enemy
     │
     ▼
Game Manager
     │
     ├── Score
     ├── Timer
     └── Game State

EnemySpawner
     │
     ▼
Enemy Instances
```

This separation makes the game easier to:

* Maintain
* Debug
* Extend
* Balance
* Scale with additional mechanics

---

## 🛠️ Technology Stack

| Technology                 | Purpose                              |
| -------------------------- | ------------------------------------ |
| **Unity**                  | Main game engine                     |
| **C#**                     | Gameplay programming                 |
| **XR Interaction Toolkit** | Virtual Reality interaction          |
| **Unity Physics**          | Collision and projectile handling    |
| **Unity Prefabs**          | Reusable game entities               |
| **Unity Scenes**           | Game environment management          |
| **Git**                    | Source control                       |
| **GitHub**                 | Repository hosting and collaboration |

---

## 📂 Project Structure

The repository follows the standard structure recommended for Unity projects.

```text
Vectra/
│
├── Assets/
│   ├── Scenes/
│   │   └── ...
│   │
│   ├── Scripts/
│   │   ├── Bullet.cs
│   │   ├── Enemy.cs
│   │   ├── EnemySpawner.cs
│   │   ├── GameManager.cs
│   │   └── Gun.cs
│   │
│   ├── Prefabs/
│   │   └── ...
│   │
│   ├── Materials/
│   │   └── ...
│   │
│   └── ...
│
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
│
├── ProjectSettings/
│   └── ...
│
├── .gitignore
└── README.md
```

> Unity-generated cache folders such as `Library/`, `Temp/`, `Logs/` and local build artifacts should not be committed to the repository.

---

## 🧩 Core Scripts

### `GameManager.cs`

Responsible for controlling the global state of the match.

Typical responsibilities include:

```text
Game timer
Score management
Game start
Game over conditions
Global gameplay state
```

---

### `Gun.cs`

Controls the player's weapon behavior.

Responsibilities may include:

```text
Player input
Projectile spawning
Fire rate
Weapon positioning
Shooting logic
```

---

### `Bullet.cs`

Controls projectile behavior after a shot is fired.

Typical responsibilities:

```text
Projectile movement
Collision detection
Enemy hit detection
Projectile destruction
```

---

### `Enemy.cs`

Represents the behavior of each enemy instance.

Possible responsibilities include:

```text
Enemy movement
Collision handling
Destruction
Score events
Combat behavior
```

---

### `EnemySpawner.cs`

Controls the generation of enemies throughout the match.

Responsibilities include:

```text
Enemy instantiation
Spawn positions
Spawn intervals
Difficulty progression
Enemy wave generation
```

---

## 🔄 Gameplay Flow

The general gameplay loop can be represented as follows:

```text
Start Game
    │
    ▼
Initialize 100-second Timer
    │
    ▼
Spawn Enemy
    │
    ▼
Player Detects Target
    │
    ▼
Player Fires Blaster
    │
    ▼
Projectile Hits Enemy
    │
    ▼
Enemy Destroyed
    │
    ▼
Score Updated
    │
    ▼
Difficulty Increases
    │
    ▼
More Enemies Spawn
    │
    ▼
Timer Reaches 0
    │
    ▼
Game Over
    │
    ▼
Final Score
```

---

## ⚙️ Requirements

Before running the project, make sure you have:

* **Git**
* **Unity Hub**
* A compatible **Unity Editor version**
* Unity modules required by the project
* XR packages configured if testing in Virtual Reality

For VR gameplay, you may additionally need:

* A compatible VR headset
* Supported controllers
* An XR runtime such as OpenXR
* Correct Unity XR configuration

---

## 🚀 Running the Project Locally

### 1. Clone the repository

Open a terminal and run:

```bash
git clone https://github.com/Sama1495/Vectra.git
```

Move into the project directory:

```bash
cd Vectra
```

---

### 2. Open Unity Hub

Launch:

```text
Unity Hub
```

Then select:

```text
Add
→ Add project from disk
```

---

### 3. Select the project

Choose the cloned project folder:

```text
Vectra/
```

or the corresponding `VT-Shooter` project directory.

---

### 4. Open the correct Unity version

Use the Unity Editor version compatible with the project.

Using a significantly different Unity version may cause:

* Package compatibility problems
* XR configuration issues
* Scene serialization changes
* Material or shader errors

---

### 5. Open the main scene

Inside Unity, navigate to:

```text
Assets/Scenes/
```

Open the main gameplay scene.

---

### 6. Run the game

Press:

```text
▶ Play
```

inside the Unity Editor.

---

## 🥽 Running in VR

For Virtual Reality execution, verify that the XR environment is correctly configured.

Inside Unity, review:

```text
Edit
└── Project Settings
    └── XR Plug-in Management
```

Make sure the appropriate XR provider is enabled.

For most modern headsets, **OpenXR** is recommended.

You should also verify:

```text
XR Interaction Toolkit
Input Actions
Controller bindings
XR Origin
Camera tracking
Interaction layers
```

before testing the application on a headset.

---

## 🧪 Testing

The project can be tested at several levels.

### Gameplay Testing

Verify:

* Weapons fire correctly
* Projectiles move correctly
* Enemy collisions are detected
* Enemies are destroyed
* Score increases properly
* Timer behaves correctly
* Game ends after the configured duration

### XR Testing

Verify:

* Controller tracking
* Weapon orientation
* Trigger input
* Player viewpoint
* XR Origin configuration
* Interaction responsiveness

### Performance Testing

Monitor:

```text
FPS
CPU usage
GPU usage
Draw calls
Physics calculations
Garbage Collection
```

using Unity's built-in Profiler.

---

## 📊 Scoring System

The scoring system rewards players for successfully eliminating enemies.

A simplified scoring flow is:

```text
Enemy Spawn
    ↓
Player Shoots
    ↓
Projectile Collision
    ↓
Enemy Destroyed
    ↓
Score Increased
```

Future versions of the system could support:

```text
Accuracy bonuses
Combo multipliers
Critical hits
Wave bonuses
Time bonuses
Difficulty multipliers
```

---

## 🔐 Version Control Strategy

This project uses **Git and GitHub** for source control.

A recommended workflow is:

```text
main
│
├── develop
│
├── feature/player-shooting
├── feature/enemy-ai
├── feature/xr-interaction
├── feature/ui
└── fix/collision-system
```

Example:

```bash
git checkout -b feature/new-enemy
```

After implementing the feature:

```bash
git add .
git commit -m "feat: add new enemy behavior"
git push origin feature/new-enemy
```

Then create a **Pull Request** on GitHub.

---

## 📝 Recommended Commit Convention

Using semantic commits keeps the repository history clean and understandable.

Examples:

```text
feat: add enemy spawning system
fix: correct bullet collision detection
refactor: simplify game manager
docs: improve project documentation
style: reorganize Unity scripts
perf: optimize enemy spawning
test: add gameplay validation
```

---

## 🗺️ Roadmap

Potential future improvements include:

* [ ] Multiple enemy types
* [ ] Advanced enemy formations
* [ ] Boss battles
* [ ] Combo multiplier system
* [ ] Weapon upgrades
* [ ] Multiple blaster types
* [ ] Power-ups
* [ ] Improved sound design
* [ ] Dynamic soundtrack
* [ ] Difficulty levels
* [ ] Global leaderboard
* [ ] Local high-score system
* [ ] Improved particle effects
* [ ] Additional VR environments
* [ ] OpenXR optimization
* [ ] Performance optimization for standalone VR headsets
* [ ] Additional game modes

---

## 💡 Possible Future Game Modes

Vectra's architecture can be expanded with additional modes such as:

### ♾️ Endless Mode

Enemies continue spawning until the player is defeated.

### ⏱️ Time Attack

Eliminate the maximum number of enemies before the timer expires.

### 👾 Survival Mode

Enemy difficulty continuously increases over time.

### 🏆 Score Attack

Players compete exclusively for the highest possible score.

### 👑 Boss Rush

Players face increasingly difficult boss encounters.

---

## ⚡ Performance Considerations

VR applications require stable frame rates to provide a comfortable experience.

Important optimization areas include:

```text
Object Pooling
Draw Call Reduction
Physics Optimization
Efficient Collision Detection
Prefab Optimization
Particle Optimization
Garbage Collection Reduction
LOD Systems
Texture Optimization
```

For projectiles and enemies, an **Object Pooling system** would be especially useful in future versions to reduce runtime instantiation and garbage collection overhead.

---

## 🤝 Contributing

Contributions, improvements and suggestions are welcome.

### Recommended workflow

Fork the repository.

Clone your fork:

```bash
git clone https://github.com/YOUR_USERNAME/Vectra.git
```

Create a feature branch:

```bash
git checkout -b feature/amazing-feature
```

Commit your changes:

```bash
git commit -m "feat: add amazing feature"
```

Push the branch:

```bash
git push origin feature/amazing-feature
```

Finally, open a **Pull Request**.

---

## 🐛 Reporting Issues

If you encounter a bug, please open an issue and include:

```text
Unity version
Operating system
VR headset, if applicable
Steps to reproduce
Expected behavior
Actual behavior
Screenshots or video
Console errors
```

Providing detailed information makes debugging significantly easier.

---

## 📜 License

This project is distributed under the **MIT License**.

You are free to:

* Use the project
* Modify the source code
* Study the implementation
* Distribute modified versions

while respecting the conditions defined by the MIT License.

See the `LICENSE` file for additional information.

---

## 🎓 Project Purpose

Vectra was developed as a practical exploration of:

* Game development with Unity
* C# programming
* Virtual Reality interaction
* XR architecture
* Physics and collision systems
* Real-time gameplay
* Game state management
* Git-based collaborative development

The project combines classic arcade game design principles with modern immersive technologies.

---

## 🌌 Final Concept

> **Classic arcade reflexes. Modern immersive technology.**

**Vectra** transforms the simplicity of traditional space shooters into a fast-paced 3D / VR combat experience where precision, speed and reaction time determine the final score.

<p align="center">
  <strong>🎯 Aim. 🔫 Fire. 👾 Survive. 🏆 Dominate the leaderboard.</strong>
</p>

---

<p align="center">
  Made with 🎮 Unity, 💻 C# and 🥽 XR.
</p>

<p align="center">
  ⭐ If you like the project, consider giving the repository a star.
</p>

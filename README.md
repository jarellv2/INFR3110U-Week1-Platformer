# Golden Axe Platformer

**Name:** Jarell Igene  
**Student Number:** 100981095  

### Gameplay Loop
The player navigates a 2D environment by moving and jumping across platforms using key controls. The core loop involves avoiding red hazard blocks that cause player defeat and reload the level, interacting with dynamically spawned items to increase score, and reaching the green goal zone to a victory state and reset the scene.

### Design Pattern Diagram (Singleton & Factory)
```mermaid
classDiagram
    class GameManager {
        - static GameManager _instance
        - int score
        + static GameManager Instance
        + void AddScore(int amount)
    }
    class ItemFactory {
        + GameObject coinPrefab
        + GameObject CreateItem(string itemType, Vector3 position)
    }
    class Coin {
        + void OnInteract()
    }
    
    Coin --> GameManager : Calls Instance.AddScore()
    ItemFactory --> Coin : Instantiates
### Reflection Questions

**1. What element of your game adopts the chosen pattern?**
The score tracking system adopts the **Singleton** pattern in `GameManager.cs`. The dynamic object creation uses a **Factory** pattern through `ItemFactory.cs` to handle spawning collectable items into the scene.

**2. Why is this pattern a good choice for the associated functionality?**
The **Singleton** pattern ensures there is only one global `GameManager` instance handling the overall game state and score. By using a public getter and private setter, any interactable object in the scene can easily call `GameManager.Instance.AddScore()` upon collection without needing complex direct script references, while also keeping the manager instance protected from unauthorized overrides.

### External Assets
- Built-in Unity 2D Primitives (Sprites, Colliders, Rigidbody2D).

### Special Instructions
To play the game, download `Platformer_Build.zip` from the **Releases** tab, extract the file, and run `GoldenAxePlatformer.exe`.

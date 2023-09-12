# Objectives of the Game

* Get all the Pizza to the Customer.
* Be cautious and avoid collisions with cows on the road, as they will decrease your movement speed.
* Collect fuel cans to restore your speed and keep the delivery going smoothly.

## How do i make the game. *First Project*

1. I started by creating various sprite shapes, including circles, rectangles, and other custom shapes.
2. I gained an understanding of void methods and how they affect the behavior of these sprites.
3. I utilized built-in Unity methods like rotation and translate to manipulate 2D objects.
4. To add flexibility to my scripts, I introduced variables that could be adjusted to change object behavior.
5. I employed the "SerializeField" attribute to tweak these variables during runtime, enhancing the game's customization.
6. For player input, I used "Input.GetAxis()" via the Input Manager, ensuring that the movement direction was correctly set up by distinguishing between negative and positive button presses.
7. To account for varying computer speeds, I applied "Time.deltaTime()" to control the game's frame rate.
8. I harnessed the power of Unity's physics system by incorporating Colliders and Rigidbodies to enable object collisions and interactions.
9. For collision detection, I relied on "OnCollisionEnter2D()" and "OnTriggerEnter2D()" methods, along with "Debug.Log()" to provide feedback when objects collided.
10. I learned how to add assets to my Unity project and adjust their pixel size to fit the desired sprite dimensions. I also created Empty Sprite World Objects to organize game elements.
11. Transforming a Capsule into a Car sprite was a breeze. I edited the Sprite Renderer and adjusted the collider's size accordingly. I organized assets by placing them under empty objects and adjusted the sprite per unit using Unity's global scene settings and grid magnet functionality.
12. To create a smooth camera movement, I implemented a POV (Point of View) script. I used the "transform.position" property to follow a target object and switched from the "Update()" method to "LateUpdate()" for a more seamless game experience.
13. I used conditional statements and tags to trigger interactions between packages and deliveries. Ensuring that the "Is Trigger" checkbox was enabled on both colliders prevented unwanted collisions.
14. I employed boolean variables to track whether a package had been picked up and could be delivered.
15. To handle package pick-up and delivery, I used the "Destroy(ObjectToDestroy, timeDelay)" method and set "hasPackaged" to false or "!hasPackaged" during pick-up to prevent collecting all the packages at once.
16. I changed the color of the player's car by using "GetComponent" and "SpriteRenderer." Additionally, I used "Color32" to select specific colors.
17. I implemented a system where colliding with a cow would reduce the player's speed, while hitting fuel cans would boost it. I also created invisible boundaries to keep the player from escaping the game map.

These steps helped me create a solid foundation for my game development journey in Unity.

Thank You.

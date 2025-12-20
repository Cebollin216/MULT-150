using UnityEngine;

/*
========================================
   GAUNTLET RUNNER – GAME CRITIC
   Fernando Ramirez – Hour 20
========================================

1) Is the game too easy or hard?

The game feels balanced but slightly challenging at first. At the beginning it can feel a little hard
because the player needs to react quickly to obstacles while learning the controls.
After playing for a short time, it becomes easier once you understand when to dodge
and when to use the powerup.

2) What changes would you do to make it easier or harder?

To make the game easier, I would slow down the obstacle spawn rate or increase the
time bonus from powerups. Another option would be making the player move slightly faster.
To make the game harder, I would increase the spawn speed of obstacles or reduce
the amount of time added by the powerups.

3) What would make the game more appealing?

The game would be more appealing with more visual variety, such as different obstacle
designs or different colors as the game progresses. Sound effects and background music
would also make the game feel more exciting and give better feedback to the player.

4) What parts of the game are fun?

Dodging obstacles and using the powerup to slow time is the most fun part of the game.
The slow motion effect makes the player feel more in control and rewards good timing.
Trying to survive longer and beat your previous time is also enjoyable.

5) What parts of the game are tedious?

The game can feel repetitive after a while because the environment stays mostly the same.
Adding more obstacle patterns or changing the level layout over time would help reduce
the repetitive feeling.

----------------------------------------
CHANGES MADE TO OBSTACLE AND POWERUP
----------------------------------------

Obstacle Changes:
- The original single cube obstacle was replaced with a more complex obstacle.
- An empty parent object was used with multiple child shapes to form a spike-style obstacle.
- Custom materials were created inside Unity and applied to the obstacle parts.
- The obstacle still uses the same collision and gameplay logic.

Powerup Changes:
- The original powerup shape was modified to look different from the book version.
- The particle system was changed (color, size, and emission settings) to make it unique.
- The powerup retains the same gameplay functionality while having a new visual style.

Textures and Materials:
- All materials were created directly in Unity using colors and emission.
- No external textures or assets were downloaded.
*/

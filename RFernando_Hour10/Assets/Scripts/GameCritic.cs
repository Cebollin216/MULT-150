/*
Hour 10 – GameCritic.cs – Fernando Ramirez

IMPROVING THE GAME (Reflection)

1) What works well in Chaos Ball:
   The rolling feels smooth and responsive, and the camera follow is clean.
   Collecting pickups is clear and satisfying because the UI updates right away.

2) What could be improved:
   I’d add sound effects and maybe some simple particles for hits/pickups.
   A couple of different layouts or levels would also make it feel more replayable.

3) How physics values affect gameplay:
   Mass, drag, and force change the “weight” of the ball. More drag = safer, slower control.
   Higher force = faster acceleration but easier to overshoot. Small tweaks totally change the feel.

4) Accessibility / UI / UX ideas:
   Big, high-contrast text for Score/Lives/Timer; clear center message for Win/Game Over.
   Simple controls (WASD/Arrows), and a restart button so you don’t have to reset manually.

EXERCISE – Enhancements Implemented (picked from the book’s ideas)

A) Restart Button: shows on YOU WIN / GAME OVER and reloads the scene.
B) Timer (count-up): displays time during play and stops on end.
C) Bumper/Hazard Variations: different sizes/shapes (cylinders + a cube) to change navigation.
D) Pickup Variations: big pickups worth 3 points, small ones worth 1 (with HUD showing both).

Summary:
I learned how to hook up UI to gameplay (score, lives, timer), manage win/lose states,
and use small physics/scene changes to affect difficulty and feel. The project plays
smooth and everything required works as expected.
*/
using UnityEngine;
public class GameCritic : MonoBehaviour { }

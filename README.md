# GameDevTV-Skill-Builder---BASIC-TELEPORTING-QUEST
Skill Builder Challenge 1
In this 3D First Person Quest we finish implementing a half-coded teleport mechanic and a bounce mechanic so that we can make a fun puzzle moment for the player. 
We use Transform.Position, coroutines, adding force and practice level layout.

Challenges For This Quest
JumpyJumpy:
Search the scripts to find where Challenge 1 is hiding and then Add Force in an upwards direction to launch the player into the air.

Teleport Player:
When the player steps on the TeleportA platform, instantly transport them to the TeleportB platform. Hint: think about how we can change a game object's position.
After the player has stepped on TeleportA, add some code to make sure the player cannot be teleported again from that particular teleport platform.

Illuminate Area:
When the player is teleported, turn on a light which illuminates where the player should go to next (eg. the next Teleport platform).

Blink World Light:
Use a coroutine to quickly blink the main world light on then off so that the player gets a glimpse at the whole level. The idea is that your world is quite dark but for a brief moment it is lit up clearly. You may need to refactor or move one of your method calls to fix any new bugs created.

Teleport Player Random:
Instead of teleporting to just one location, randomly teleport the player to one of many locations. Hint: You may need to use an array.

Design a puzzle:
Now that we have 3 gameplay mechanics (bouncing, teleporting and switching lights on and off) create a small puzzle for the player where they have to figure out how to get from start to finish. Feel free to rearrange the existing level, add geometry, create puzzles and even add more features if you'd like. And then share your creation with other club members (either as a build uploaded to Sharemygame.com or as a short 30 second gameplay video).

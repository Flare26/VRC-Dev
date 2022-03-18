
Never Have I Ever by Fionn#5639
---------------------------------



Download the latest VRChat SDK: 
https://vrchat.com/home/download

Download CyanTriggers: 
https://cyanlaser.booth.pm/items/3194594
https://patreon.com/CyanLaser 

Download CyanEmu:
https://github.com/CyanLaser/CyanEmu
VRCPrefabs Database:
https://vrcprefabs.com/browse

-----------------
INSTRUCTIONS
-----------------
Before importing this package, please install CyanTriggers and the latest VRChat SDK3 from the above links.

It is strongly recommended to also install CyanEmu.

-------------------------
NEVER HAVE I EVER
-------------------------
Drag and drop the Never Have I Ever prefab into the scene.  You can replace the visual components of most of the objects.

PlayerListLogic:  
-  To change the material that the score lines change to when stepped on, drop the new material in pressedMaterial.
-  This object also controls the text for the scoreboard.  If you change the font or maxNameLength, you will likely have to adjust the TextMeshPro font size and width to ensure correct wrapping.  
 Play and Audio Area:
 -  This collider determines the area that players will hear the microphone in, and be displayed on the scoreboards.  Adjust the size of this collider to match your play area.
 
 Microphone:
 - The microphone must be clicked at least once per new question for the scoreboard to display accurately and the lines to light up.
 - To add to or change the suggestions displayed, go to the object Never Have I Ever/Microphone/Instruction Screen/Suggestions.  In the CyanTrigger, click the Edit button on the suggestions variable.  You can change the number of suggestions and the text.  
 
 Scorelines: 
 - To add more "Scorelines", duplicate one of the NHIE-Scoreline objects and edit the colliderScore variable to be +1 from the previous one.  Do not drag a new prefab in, it will not retain the correct references.  Duplicate one from the scene instead.  Size of the lines can be adjusted.




Technical notes: 

The prefab differs slightly from the tutorial version, in that the ball has some added logic that allows the other player to see a more accurate physics representation of the ball, as opposed to the normal VRCObjectSync behavior which is interpolated and quite "floaty".  The downside is that the ball is not able to be picked up by anyone but the last person who threw it without using a respawn button.  This is done by enabling a non-synced physics proxy and the moment of release for remote users.  The person who threw the ball will determine the accurate behavior, whether a cup is hit or not.
The proxy's position is approximate and may not match between users, it's for "visual immersion" only.  Note that this ball requires a slightly modified Respawner object.  

The audio effects on the ball are covered in the Collision Audio tutorial, also available at youtube.com/CyanLaser


This file is released under Creative Commons CC BY 4.0

https://creativecommons.org/licenses/by/4.0/

You may copy, distribute, adapt, and use this material for any purpose, with attribution:
Fionna#5639 Disord, @jendaviswilson on Twitter

Hologram shader by orels1



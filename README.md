NOTE: In the actual unity console the game works perfectly fine (at least on my end) but for some reason the website version of it is a completely different movement speed and I have no idea why...I still talk about my process and everything

Link: https://play.unity.com/en/games/4f308894-40dd-4739-b56c-d249a6a43d30/pumpkin-coin-collect


Controls:

-> A or left arrow to go left

-> D or right arrow to go right

-> Space bar to jump

-> R to restart game early

[Game Description:]

In this one-level snippet of the game, we continue the “Boo the Ghost” saga. Rather than being in space though dodging ginormous pumpkins, we are now in a parkour game 
where the player has to collect all of the pumpkin coins.

In order to win, the player must collect all the coins within the time limit. If they succeed, the game will display a “You Win” message and restart the level. If the 
player is unsuccessful in collecting all the coins within the one minute time limit, a “You Lose” message will appear and the level will restart.

I think the challenge of collecting all the coins before the timer runs out is the most engaging part of the game, since it's a challenge with the stakes being:
"Lose all your progress".

[Technical Implementation:]

1. Levels - This game consists of one level with the objective being: Collect all the coins within the time limit. I think it is made clear with the countdown
and coin collected counter.

2. Sprites and Prefabs - There are various sprites used in this game (each in their respective folders), such as the player, the coins, the boxes, the walls, and the platforms. Theplayer sprite is actually controlled by the user using the above controls. Meanwhile the coins and boxes are what the player interact with, either to help get onto higher platforms or to increase the score. On the other hand, the walls and platform are just act as barriers. I saved all of these, but the player, into a prefab for unity and efficiency.

3. Colliders, Trigger, and Rigidbodies - The coins, boxes, and player all have a 2Drigidbody and 2Dcollider so they can interact with one another in their respective ways. The coin is also marked as a trigger so it can disappear and initiate a particle effect when collected (as well as increase the counter). Meanwhile the walls and platforms only have a collider since they are just barriers.

5. UI Text - There are two interactive labels that consistently update, the score label and the time left label. The score label updates each time a coin is collected, while the time left label updates each second (using the delta time feature). Each of these are in the CoinCollision code. When the time runs out or the coins are all collected a message will appear and the game will restart automatically.

6. Particle System - The only particle system I implemented is the tiny particle explosion that is instantiated and deleted quickly when a coin is collected. This is done in the CoinCollision script.

[Future Development]

If I were to work on this game further I would love to implement sound effects! I would also like to make more levels and an intro for a better, more cohesive narrative. 
Furthermore, I would aim to add more puzzles that make the game get progressively more difficult as you get further and further into the game (or even add enemies and a health bar). Perhaps I'll do this over winter break...

[Development Reflection]

Overall, the game wasn't too bad to make, a lot of the issues I had were related to mistakes I made when initializing everything, such as the score not updating properly
or the ghost glitching through the walls (normally that be realistic, but this ghost isn't suppose to be that powerful). I will say, there are still a bit of issues with the movement speed and jump force being a bit much, but we won't say that's a bug...but rather a feature to make the game more difficult. 

Through this project though, I learned a lot about unity and how to make a game from scratch (ideas and everything). The sprite flight was very structured and although we learned the basics about making a game we didn't get the opportunity to get really creative like with this!

If I did this again, I would definitely start really early (I procrasinated a bit too much) and come up with a narrative to implement!

[Resources Used]

- Quad Center
- https://youtu.be/FO7auF7zXpU?feature=shared
	- For Jumping Mechanic
- https://youtu.be/92DYkgBJBBo?feature=shared 
	- Also for Jumping Mechanic
- https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Rigidbody2D.AddForce.html 
	- Movement
- https://www.bytehide.com/blog/string-to-int-csharp#:~:text=In%20C%23%2C%20we%20mainly%20have,On%20the%20other%20hand%2C%20Int32. 
	- For Score
- https://learn.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-9.0 
	- Also For Score
- https://learn.unity.com/course/2d-beginner-game-sprite-flight/tutorial/restart-the-game-with-a-bang?version=6.0#682caaffedbc2a0130c31417




     



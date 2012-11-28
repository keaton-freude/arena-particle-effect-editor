1) What is this program?? How did it end up on my computer??

This program is used to create custom 2-D particle effects in conjuction with the Arena.ParticleEngine namespace created by Keaton Freude for Senior Project @ OIT Portland. It ended up on your computer because you were interested in it and requested a copy; snagged a copy of it off of my github account; or you're evaluating the program for some reason. Or maybe (doubt it) you're using it to create awesome particle effects for a game written in the XNANF framework. What is XNANF? I don't even know... it's a more robust game development framework I guess.

2) What can I expect to get out of this program?

I'll divide this in two categories:

a) For fun use:
You can expect to create some bitching particle effects. The imagination is really your limit (and supply of good base-textures). You can build particle effects, watch them render and save them for later if you want to show them off. This program can also be a good tool to learn how to create particle effects in more complicated systems (maybe? I mean the concepts are usually very similar).

b) For hobbyist Gamedev use:
So someone managed to trick you into using XNANF and you want to add some bitching particle effects. Right on. You use this program to create particle effects, test them, view them and eventually save them to file. They are saved to raw .xml file format describing the state of the system. You can then load these systems into the Arena.ParticleEngine namespace and render them.

The particle engine gives you 100% control over every single aspect of your particle effects. The concept of encapsulation was thrown out the window in favor of complete customizability. You simply use this program to get 80-85% of the work done ahead of time. You could hand-code every single particle-effect if you'd like. I know I did for a long time. But it gets old fast. Use this program to speed up the experimentation phase of the process and tweak values in game to make it fit your game.

3) Okay I'm sold. How do I create a particle effect?

I'm going to assume you just opened the program. Follow this basic train of thought:

-Click Set Emitter Location button and click somewhere in the render-window. You should see a marker. This is the base origin for all spawned particles.
-Click Emitter Properties. This pops a dialog that asks you to define HOW the particles behave in terms of physics (and rate of spawning and max spawning). You're going to have to play with these a lot. Remember that the particle engine will correctly time-step values of seconds (and smaller). So if you choose <0, 10> for your velocity vector. Expect your particle(s) to move down 10 units after one second (slow as hell).
-Next, you need to add to the list of Master-Particles. This is done by pressing Add Particle button beneath the beautiful list-box.
	-A particle has a lot of different properties that define how it looks while its in action. Most properties are linearly interpolated based on particle life. So if you have StartColor and EndColor, the particle starts as StartColor and as its life terminates he will be EndColor. Halfway between StartColor and EndColor the color shall be evenly distributed between Start and End. This goes for A LOT of the value.
	-After pickig all of the basic attributes (if you don't want things like scale to change over time, choose the same Start/End) you need to pick the texture that the particle will be drawn as. This is one of the most important (if not the most important) part of the process. Choosing a good texture is key. Look online for more thoughts and tips on this consideration.
	-Finally press Submit.
-You can edit any particle (or remove the particle) from the list by selecting it and pressing the appropriate button.
-Next choose Round Robin or Random Texture Polling. For massive particle quanities the difference isn't huge, but for smaller amounts it can be useful.
-Next you choose the effect type.
	-We can break the effects down into either One Shot or Continuous. One Shot effects can be played many different times in different areas of the screen and will spawn all of their particles immediately. Great for explosions, swords scraping against walls, water splashes, etc.
	-Continuous is for things that should happen until you want to turn them off. Good for smoke, fire, fog, rain, etc.

-If you chose continuous, a lot of the options for this effect are locatd in the Emitter Properties dialog. These are ignored for one-shot particle effects and you need to say how many particles you want in the resulting text-box popup.
-Finally choose the type of one shot. Circle is very versatile, but what it does is spawn particles along the edge of a circle of the radius of your choosing. Choose radius of 1 or 0 or whatever to make a point effect. Iterations will allow you to spawn particles inside a circle. Two will create particles on the outside of a circle and around the outside of a circle of radius / 2, and this continues recursively.

-Finally choose Alpha Blending or Additive Blending. Look this up online if you dont know the difference.

-To Test go to System->GO!.
-To Save go to File->Save System.
-To Load go to File->Load System.
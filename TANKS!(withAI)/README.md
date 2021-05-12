# TANKS!(withAI)

## About
There are some great tutorials out there to get started in unity. This project is an extension of the Tanks game as part of a great tutorial series form [Unite Boston 2015](https://learn.unity.com/project/tanks-tutorial).

The core goal here is to implement a functional game where enemy tanks will patrol, and attack you if noticed. The enemy AIs here are implemented using the concept of a "finite state machine".

## Finite State Machine

<img src="https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/media/Capture.JPG" alt="finite state machine" width="400" height="300"/>

The machine we're building here will have states that interact like this:

<img src="https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/media/finite_states_applied.JPG" alt="finite states applied" width="400" height="200"/>

I'd recommend checking out the tutorial directly if you're unfamiliar with finite state machines, but the gist of it is that the logic of a StateController class determines when an AI changes states, and each state has a logic of actions, decisions, and transitions.

<img src="https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/media/state_controller.JPG" alt="state controller" width="400" height="200"/>

Thus each AI will behave according to this:

<img src="https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/media/finite_states_applied_with_details.JPG" alt="finite states applied with details" width="400" height="200"/>

This logic is implemented in [Assets/PluggableAI/Scripts](https://github.com/hrand1005/unity-projects/tree/main/TANKS!(withAI)/Assets/PluggableAI/Scripts).

## Important Changes
All put together, a successful tutorial will leave you with something like this:

![ChaserAI](https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/media/ChaserAI.mp4)

But the fun part is implementing new types of AIs, and thus new states and actions. Enter the all-new buzzsaw AI (patent-pending):

(BuzzSaw video)

...and the coward AI...

(coward video)

A variety of AIs make for a whole new gaming experience, improving replayability and longevity.

(full video with new AIs)

### New Scripts

* [BuzzSawAction.cs](https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/Assets/PluggableAI/Scripts/BuzzsawAction.cs)
* [BuzzSawDecision.cs](https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/Assets/PluggableAI/Scripts/BuzzsawDecision.cs)
* [FleeAction.cs](https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/Assets/PluggableAI/Scripts/FleeAction.cs)
* [FleeDecision.cs](https://github.com/hrand1005/unity-projects/blob/main/TANKS!(withAI)/Assets/PluggableAI/Scripts/FleeDecision.cs)

## Credits

* [Unity Pluggabe AI Tutorial](https://unity3d.com/learn/tutorials/topics/navigation/finite-state-ai-delegate-pattern)
* [Free Chainsaw Sound](https://www.freesoundeffects.com/free-sounds/chainsaw-10078/)
* [Free Human Scream Sound](https://www.freesoundeffects.com/free-sounds/screams-10094/)



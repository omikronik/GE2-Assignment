## Readme first

I was not doing well with Godot and for better or worse, decided to switch to unity last minute...

---

# Project Title: Tribalism

## Name
Yasir Celtik

## Student Number
C19307843

## Class Group
TU857

## Solo project

---

# Description

The project revolves around creating a simulation of
a tribal like society, where members live around a tribe hut.
This hut is where they will gather at night and go out
from during the day.
The aim of the villagers is to wander around during
the daytime, until they run into a berry bush which they can scavenged.

Ideas for features are:
- Multiple tribes
  - Differing tribe members can attack and kill one another, as berries are sparse. At the start of the day, if the number of villagers that returned is not equal to the previous days population, that means someone died
  - Attack groups
    - If there are missing villagers, meaning they died (or glitched out lol) a hunting party will be formed to get revenge.
- Collecting a number of berries in the home will add a villager.
- Not collecting enough berries will result in starvation.

# How it works

The villagers rely on Finite State Machines to manage what they are doing at any given moment, following the design pattern, multiple states have been added:

## Local States
- ScavengeState
  - This is the default wandering search state
- GoToBerryState
  - Arrive behaviour used to go to a berry that is spotted
- GoToBaseState
  - State to return to home
- AttackState
  - State to attack
- NearestPursue
  - Pursue the nearest enemy tribesperson
- LeaderFollow
  - a villager will be designated leader
  - those with leaderfollow state will be followers using OffsetPursue

## Global States
- Alive
  - Control death

# List of classes/assets

**All 3D models in use made by me in blender**

| Class/Asset | Source |
| - | - |
| FPSController | GE module, modified by me|
| State | own |
| Boid | GE module, modified by me|
| SteeringBehaviour | GE module |
| JitterWander | GE module |
| ObstacleAvoidance | GE module |
|VillagerController| own |
|BerryController| own |

I think this was an interesting module, certainly was fun. It feels good to have visual feedback of all the implemented systems working in tandem.
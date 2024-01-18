# ascii maze

Program for generating a maze using one of two algorithms, displaying it as ascii art, and saving it as a txt file.

(Must be viewed with Monospace font for intended effect.)

## How To Run

To run the project use

```console
dotnet run -- <ALGORITHM> <HEIGHT> <WIDTH> [<PATH>]
```

Parameter   | Description
------------|-------------------------------------------
ALGORITHM   | The chosen maze generation algorithm, see [Algorithms](#algorithms) for valid options
HEIGHT      | The height of the maze to generate.
Width       | The width of the maze to generate.
PATH        | The file path to save the maze at.

## Algorithms

name    | Description
--------|---------------------------------------------------------
DFS     | Randomized Depth-First Search or Recursive Backtracker.
Kruskal | Iterative Randomized Kruskal's Algorithm (with sets).

## Examples

### 5 x 5 DFS

```text
###########
#...#.#...#
###.#.#.#.#
#...#...#.#
#.#######.#
#.#.......#
#.#.#####.#
#...#...#.#
#####.#.#.#
#.....#...#
###########
```

### 10 x 10 DFS

```text
#####################
#.....#...#.....#...#
#####.#.#.#.###.###.#
#...#...#.#...#.#...#
#.#.#####.###.#.#.#.#
#.#.....#.#...#...#.#
#.#####.#.#.#######.#
#...#...#...#.....#.#
#.#.#.#######.###.#.#
#.#.#.#...#...#.#...#
###.#.###.#.###.#####
#...#.#...#...#.....#
#.###.#.#####.###.#.#
#...#.#.....#.....#.#
#.#.#.###.#########.#
#.#.#...#.#.......#.#
###.###.#.#.#####.#.#
#...#.....#.....#.#.#
#.#############.#.#.#
#...............#...#
#####################
```

### 30 x 30 DFS

```text
#############################################################
#.#.........#.....................#.....#.....#.............#
#.###.#####.#.###################.###.#.###.#.###########.#.#
#.....#...#.#...#.....#.#.......#.....#...#.#...#.......#.#.#
#########.#.###.#.###.#.#.###.###########.#.###.#.#####.#.#.#
#.#.......#...#...#...#...#.#...........#...#...#.....#...#.#
#.#.###.#####.#####.###.###.#####.#####.#####.###.###.#####.#
#.#.#.#.....#.#.....#...#.......#.#.....#...#.#...#...#.....#
#.#.#.###.#.#.#.#####.#########.#.###.###.#.#.#####.#########
#.#.#.#...#.#.#...#...#...#.....#...#.#...#.#.....#.........#
#.#.#.#.#####.#.#.#.###.#.#.#.#####.#.#.###.#####.#.#######.#
#.#...#...#...#.#.#...#.#.#.#.#.....#...#...#.#...#.#.....#.#
#.###.###.#.#####.###.#.#.#.#.#.#########.###.#.###.###.#.#.#
#...#...#...#.....#.#...#.#.#.#.........#.....#...#...#.#.#.#
###.###.#####.#.###.#####.#.###########.#####.###.###.#.###.#
#.....#.....#.#.#.#.....#.#.#...#.......#.#...#.#...#...#...#
#.#########.###.#.#.#.#.#.#.#.#.#.#.#####.#.###.###.#####.#.#
#.........#.#...#.#.#.#.#.#...#.#.#.#...#.#.#.....#.....#.#.#
#.###.###.#.#.###.#.#.###.#.###.#.###.#.#.#.###.#######.#.###
#.#...#...#...#.#...#.....#...#.#.....#.#.#...#.#.......#...#
###.###########.#.#############.#######.#.###.#.#.#########.#
#...#.....#.......#.....#.........#...#.#...#...#.#.........#
#.###.###.#.#########.#.#.#.###.###.#.#.#.#.###.#.###.#######
#.....#.#...#.........#.#.#.#...#...#...#.#.....#...#.#.....#
#.#####.#########.#.###.#.#.#####.#######.#########.#.#.###.#
#.......#.......#.#.#...#.#.....#.#.#.....#.......#.#.#.#...#
#######.###.###.#.#.###.###.###.#.#.#.#####.#.#####.#.#.#.#.#
#.....#.#...#.#.#.#...#...#...#.#.#.#.#.....#.#.....#...#.#.#
#.###.#.#.###.#.#####.###.#.###.#.#.#.###.#####.#########.###
#...#.#.#.#...#.....#...#.#.#...#.#.......#...#.#.......#...#
#.#.#.#.#.#.#######.###.#.#.#.###.#######.#.#.#.#.#####.###.#
#.#.#.#...#.#.....#.#...#.#.#...#...#.....#.#...#.#.....#...#
#.#.#######.#.#.#.#.#.###.###.#.###.#######.#####.#.#####.#.#
#.#.....#.....#.#.#.#...#...#.#...#.......#...#...#...#...#.#
#.###.###.#####.#.#.###.###.###.#########.###.###.###.#.#.###
#...#.......#...#.#.....#.#...#.#.......#.#...#...#.#.#.#...#
###.#########.#.#########.###.#.#.#####.#.#.###.###.#.#####.#
#.#...#.....#.#.#...........#.#...#.....#.#.#...#...........#
#.###.#.###.#.#.#.###.#####.#.#####.###.#.#.#.#.###########.#
#.....#.#.....#.#.#...#...#.#.....#...#.#...#.#.....#.....#.#
#.#####.#.#######.#.###.#.#######.#.#.#######.#####.#.###.#.#
#.#.....#.#...#...#.....#.....#...#.#.......#.#...#.#...#.#.#
###.#####.#.#.#.###########.###.#######.#.###.###.#.###.###.#
#...#...#.#.#...#...#.....#.#...#.....#.#...#.#...#...#.....#
#.#####.#.#.#######.#.###.#.#.###.###.#####.#.#.#.###.#####.#
#...#...#.#.........#...#...#.#...#.#.#.....#.#.#.#...#...#.#
#.#.#.#.#.#########.###.#####.#.###.#.#.#####.#.###.###.#.###
#.#.#.#.#...#.....#.#.#.....#.#...#...#...#...#...#.....#...#
###.#.#####.#####.#.#.#####.#.###.#.#####.#.#####.#########.#
#...#...........#.#.......#.#.#...#.#.....#.......#.#...#...#
#.#######.#####.#.#####.###.#.#.###.#.###########.#.#.#.#.#.#
#.......#.#...#.....#...#...#.#.#...#.#...#.......#.#.#...#.#
#.#####.###.#.#####.#.###.#.#.#.#.###.#.#.#.#####.#.#.#######
#.#...#.#...#.#.....#...#.#.#...#.#.....#...#...#.#.#...#...#
#.#.#.#.#.###.#####.###.#.#.#####.###########.#.#.#.###.#.#.#
#.#.#.#.#.#.#.....#.#...#.#.#...#...#.....#...#.#.....#...#.#
#.#.###.#.#.#####.###.###.#.###.###.#.###.#.###.###########.#
#.#...#.#.......#.....#.#.#.......#.#...#...#.#.......#.....#
#.###.#.#######.#######.#.#########.###.#####.#######.#.###.#
#.....#.................#...............#...............#...#
#############################################################
```

### 5 x 5 Kruskal

```text
###########
#.....#...#
###.#.###.#
#.#.#.#...#
#.###.#.#.#
#.......#.#
###.#.#.#.#
#...#.#.#.#
#.#.#####.#
#.#.....#.#
###########
```

### 10 x 10 Kruskal

```text
#####################
#...#.........#.....#
#.#####.#######.#.###
#.#.#...#...#...#...#
#.#.#.#.#.###.###.#.#
#...#.#.#...#.#...#.#
#.###.#####.#.#.#####
#.....#...#.#.#...#.#
#.#.###.#.#.#.#.###.#
#.#...#.#.....#...#.#
###.###.#.###.#####.#
#.....#.#...#.......#
#.###.###.###.#.#.###
#.#.#...#...#.#.#...#
#.#.###.#.###.#####.#
#.#.#.#...#...#.....#
#.#.#.###.#####.#.###
#...#.#.......#.#...#
#.###.#.#.#.#####.#.#
#...#...#.#...#...#.#
#####################
```

### 30 x 30 Kruskal

```text
#############################################################
#.....#...#.......#.....#...#.....#.#.#.............#.......#
###.###.###.#####.#####.#.###.#.#.#.#.#####.#####.#####.###.#
#.............#.....#.#.......#.#.......#.....#.#.#.#...#...#
#.#####.#############.#.###########.#####.###.#.#.#.#####.###
#.#.#.#.#...#.#.....#...#...#...............#...#.#.......#.#
#.#.#.#.#.#.#.###.#####.###.#.#######.#######.#.#####.###.#.#
#.#.#.#.#.#.........#.#...#...#.#.#.......#...#.#.....#.....#
#.#.#.#.#####.#####.#.#######.#.#.#####.#######.#.#####.#.#.#
#...#...#...#.#...#.#.#...#.#.#.........#.....#.#.....#.#.#.#
#####.###.#.#.#.###.#.###.#.###.#######.#####.#.#.#.#####.###
#.#...#.#.#.......#.....#.#...#.#.......#...#...#.#.#...#...#
#.#.###.###.#.#.#.###.###.#.#####.###.#####.#.#.#.#####.###.#
#...........#.#.#.#.#.#.#...#...#...#.#.......#.......#.#.#.#
#.#####.#.#########.#.#.#.#.#.#######.#####.#####.#.###.#.#.#
#.#...#.#.#.#.#...#.#.....#.............#...#.#.#.#.....#...#
###.#####.#.#.###.#.#####.###.#######.#####.#.#.#####.#.#.###
#.....#.#.#.#...............#.#.#...#.#.......#...#...#.#...#
#.###.#.###.###.#.###.###.#####.#.#.###.#.#.###.#############
#.#...#.....#.#.#...#.#.......#...#.....#.#.............#...#
#.#######.###.#######.#.#####################.#######.#####.#
#.......#...........#.#...#.......#.......#.#.#...#.#.#.....#
###.###.#########.#####.###.#.#.###.#####.#.#.#.###.#.###.###
#...#.....#.#.#...........#.#.#...#...#.....#...#.........#.#
#####.###.#.#.#.#.###.#########.###.#######.#####.###.#.###.#
#.#...#...#...#.#.#.#...#.#.#.....#.#.........#...#...#.....#
#.#.#####.#.#####.#.#.###.#.#.###.#.#.###.###.#.###.#.#####.#
#.#...#...#.....#...#.#.......#.#.#.#...#.#.......#.#.....#.#
#.###.#.#.#.#.###.#######.#####.#############.###.#####.#####
#...#.#.#.#.#.........#...................#.#...#.#.....#...#
#.#.###.#.###.#####.#########.#####.#####.#.#.#########.###.#
#.#.#...#.#.......#.....#.#...#.#...#.......#.#.#.........#.#
#.#.#.#.#####.#####.#.#.#.#.#.#.###.#####.###.#.#.###.###.#.#
#.#...#.#...#.#...#.#.#.#.#.#.#.#...#.....#...#.....#.#.#...#
#####.###.###.#.#######.#.#####.###.###########.#.#####.###.#
#...........#...#...#...#...#.............#.#.#.#.#.....#...#
#####.#.#######.#.###.#.#.#######.#.#.###.#.#.###.#.#######.#
#...#.#.#.#.....#.#...#.....#.#...#.#.#.........#...#...#.#.#
###.###.#.###.###.#.#####.###.###.###.#########.###.###.#.#.#
#.#.....#.#.......#.#.#.#.#.........#.#...#...........#.#.#.#
#.#.#####.#####.#.###.#.#####.#.#########.###.###.#####.#.###
#.....#.#.......#.....#...#...#.#...#.....#...#.............#
###.###.###.#.#########.###.###.###.#.###.#.#.#####.#.###.#.#
#.....#.....#...#.#...#.....#...........#.#.#...#...#...#.#.#
###.###.#######.#.###.#######.#####.#.###############.###.#.#
#.#.......#...#...#.....#.#...#.#.#.#.#.....#...#.#.....#.#.#
#.#######.###.###.###.###.#####.#.#########.###.#.#.###.#.###
#.........#...#.....#...#.......#.........#.#.........#.#.#.#
#####.#.###.#.###.###.#.#####.#####.#######.#########.#####.#
#.#.#.#...#.#...#...#.#.#.....#...........#...#.......#.....#
#.#.#.#.#####.#.#.###.###.#.#####.#.#####.###.#.#######.###.#
#.....#.#...#.#.#.....#...#.#.#...#...#...#...#.......#.#...#
#.#######.###.#.#####.###.###.#.###.###.###.#####.#####.#####
#...#...#.#.#.#...#.#...#...#.#.#.#.#.#...........#.#...#.#.#
#.#####.#.#.#.#.###.###.#.###.###.###.#.#.#########.###.#.#.#
#.#.....#.#...#.......#.........#.....#.#.....#...#.......#.#
###.#.#.#.#.###.#.#.###.###.#######.###.#####.#.#.#.#####.#.#
#...#.#.#.....#.#.#.....#.....#.......#.#.....#.#...#...#...#
#######.###.###.###.#.#.###.###.#.#.#.#.###.#######.###.###.#
#.............#...#.#.#...#.#...#.#.#...#...........#.......#
#############################################################
```

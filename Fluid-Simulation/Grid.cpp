// Grid.cpp : This file creates the "Grid" layout 
// -> each grid represents a section of fluid, it has some density, velocity, etc.
// -> each grid cell interacts with its neighbors
// https://cg.iit.bme.hu/visualization/gridfluid/downloads/gridfluid-sva-0.1.pdf
//using namespace std
#include <iostream>
#include <vector>
#include <math.h>
#include <Windows.h>
#include "GridCell.cpp"


class Grid {
public: 
	const int width = 100;
	const int height = 100;
	GridCell theGrid[100][100];
	int neighbors(int x, int y);

};

int Grid::neighbors(int x, int y) {
	int output[4][2] = {
		{ max(x - 1, 0), y},
		{x, min(y + 1, height)},
		{min(x + 1, width), y},
		{x, max(y - 1, 0)}
	};
	return 0;
}
// GridCell.cpp : This file creates the "GridCell" class 
// -> each grid represents a section of fluid, it has some density, velocity, etc.
// -> each grid cell interacts with its neighbors
//
//using namespace std
#include <iostream>
#include <vector>
#include <math.h>
#include <Windows.h>


class GridCell {
public:
	int density;
	int viscosity;

	int update(int neighbors) {
		int output = 0;
		return output;
	}

};

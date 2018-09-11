#include<iostream>
using namespace std;

class Point
{
public:
	
	Point(Size);
	~Point();

private:
	int *arr;
};

Point::Point(Size)
{
	
	 = new int[Size];

}

Point::~Point()
{
	delete[] arr;
}


int main()
{

	return 0;
}
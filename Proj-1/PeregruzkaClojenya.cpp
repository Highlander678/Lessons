#include<iostream>

using namespace std;
//Перегрузка оператора сложения
//Написать перегрузку оператора =
class Point
{
public:
	
	
	
	Point() {
	};
	Point(int Size);
	Point(Point &other);
	
	Point operator+(const Point &other);
	
	void GetArr();
	void GetSummTMP();
	~Point();

private:

	int Size;
	int *arr;
	
};

Point::Point(int Size)
{
	this->Size = Size;
	arr = new int[Size];
	for (int i = 0; i < Size; i++)
	{
		arr[i] = rand() % 30;
	}
}

Point::Point(Point & other)
{
	this->Size = other.Size;
	this->arr = new int[this->Size];
	for (int i = 0; i < this->Size; i++)
	{
		this->arr[i] = other.arr[i];
	}
}

 Point Point::operator+(const Point & other)
{
	 if (this->Size >= other.Size) {}
	else this->Size = other.Size;

	for (int i = 0; i < this->Size; i++)
	{
		this->arr[i] = this->arr[i] + other.arr[i];
	}
	return *this;
}



void Point::GetArr()
{
	for (int i = 0; i < this->Size; i++)
	{
		cout << "arr[" << i << "] =\t" << this->arr[i] << endl;
	}
}



Point::~Point()
{
	delete[] this->arr;
	
}

int main()
{
	int Size;
	cin >> Size;
	Point A(Size);
	Point B(Size);
	//Point C(Size);

	setlocale(LC_ALL, "ru");
	cout << "Массива объекта ============================== А ======================" << endl;
	A.GetArr();
	cout << "Массива объекта ============================== B ======================" << endl;
	B.GetArr();
	A + B;
	Point C(A);

	
	cout << "Результат суммы ============================== C ======================" << endl;
	C.GetArr();

	system("pause");

	return 0;

}
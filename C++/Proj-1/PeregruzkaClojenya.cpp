#include<iostream>

using namespace std;
//Перегрузка оператора сложения
//Написать перегрузку оператора =
class Point
{
public:
	Point(int Size);
	int operator+(Point & other);
	void operator=(Point &other);
	void GetArr();
	void GetSummTMP();
	~Point();

private:
	int Size;
	int *arr;
	int *tmp;
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

int Point::operator+(Point & other)
{
	int Size;
	if (this->Size >= other.Size) Size = this->Size;
	else Size = other.Size;
	this->tmp = new int[Size];

	for (int i = 0; i < Size; i++)
	{
		tmp[i] = this->arr[i] + other.arr[i];
	}


	return 0;
}

void Point::operator=(Point & other)
{

}

void Point::GetArr()
{
	for (int i = 0; i < this->Size; i++)
	{
		cout << "arr[" << i << "] =\t" << this->arr[i] << endl;
	}
}

void Point::GetSummTMP()
{
	for (int i = 0; i < this->Size; i++)
	{
		cout << "arr[" << i << "] =\t" << this->tmp[i] << endl;
	}
}

Point::~Point()
{
	delete[] this->arr;
	delete[] this->tmp;
}

int main()
{
	int Size;
	cin >> Size;
	Point A(Size);
	Point B(Size);
	setlocale(LC_ALL, "ru");
	cout << "Массива объекта ============================== А ======================" << endl;
	A.GetArr();
	cout << "Массива объекта ============================== B ======================" << endl;
	B.GetArr();

	A + B;

	cout << "Результат суммы ============================== А ======================" << endl;
	A.GetSummTMP();
	system("pause");

	return 0;

}
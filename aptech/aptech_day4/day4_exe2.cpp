#include <stdio.h>

int main (int argc, char *argv[])
{
  int num = 555;
  printf("[%d]\n", num);
  printf("[%-d]\n", num); // canh trái nếu có khoảng trống
  printf("[%10d]\n", num); // tạo 1 khoảng trống 10 ký tư
  printf("[%0d]\n", num);
  printf("[%010d]\n", num); //thay khoảng trắng bằng số 0
  printf("[%-10d]\n", num);
  printf("[%-010d]", num);
}

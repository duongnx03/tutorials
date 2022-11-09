#include <stdio.h>

int num = 2;

void fun1(){
  num = num + 3;
}

void fun2(){
  num = num + 1;
}

int main(){
  fun1();
  fun2();
  printf("Num: %d \n", num);
}


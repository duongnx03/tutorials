#include <iostream>

int main (int argc, char *argv[])
{int a, b, c, max;

  printf("Input a: \n");
  scanf("%d", &a);
 
  printf("Input b: \n");
  scanf("%d", &b);

  printf("Input c: \n");
  scanf("%d", &c);

  max = a;

  if(b > max){
    max = b;
  }
  if (c > max) {
    max = c; 
  }
  printf("so lon nhat la %d\n", max);
  return 0;

}
//check max:
/*
if(a>b && a>c){
  printf("max is %d\n", a);
if(b>a && b>c){
  printf("max is %d\n", a)
if(c>b && c>a){
  printf("max is %d\n", a);;
}
*/
//check min
/*
if(a<b && a<c){
  printf("max is %d\n", a);
if(b<a && b<c){
  printf("max is %d\n", a)
if(c<b && c<a){
  printf("max is %d\n", a);;
}
*/

#include <stdio.h>

int main(){

  struct student{
    int id;
    char name[25];
    char sclass[20];
    int mark;
  };

  struct student stus[3];

  //dung vong lap de nhap 
  for (int i = 0; i < 3; i++) {
    printf("Input for student%d\n", i);
    printf("Input id: \n");
    scanf("%d", &stus[i].id);
    printf("Input name: \n");
    fflush(stdin);
    gets(stus[i].name);
    printf("Input sclass: \n");
    gets(stus[i].sclass);
    printf("Input mark: \n");
    scanf("%d", &stus[i].mark);
  }

  for (int i = 0; i < 3; i++) {
    printf("Student%3d: id:%d, name:%10s, sclass:%10s, mark:%3d\n", i, stus[i].id, stus[i].name, stus[i].sclass, stus[i].mark);
  }
}

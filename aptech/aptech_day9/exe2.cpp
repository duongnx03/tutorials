#include <stdio.h>

int main(){

  struct student
  {
    int id;
    char name[25];
    char sclass[20];
    int mark;
  };

  struct student student1, student2;

  printf("Input for student1");
  printf("Input id: \n");
  scanf("%d", &student1.id);
  printf("Input name: \n");
  fflush(stdin);
  gets(student1.name);
  printf("Input sclass: \n");
  gets(student1.sclass);
  printf("Input mark: \n");
  scanf("%d", &student1.mark);
  printf("Input for student2 ");
  printf("Input id: \n");
  scanf("%d", &student2.id);
  printf("Input name: \n");
  fflush(stdin);
  gets(student2.name);
  printf("Input sclass: \n");
  gets(student2.sclass);
  printf("Input mark: \n");
  scanf("%d", &student2.mark);
  
  printf("Student1: id:%d, name:%s, sclass:%s, mark:%d", student1.id, student1.name, student1.sclass, student1.mark);
  printf("Student1: id:%d, name:%s, sclass:%s, mark:%d", student2.id, student2.name, student2.sclass, student2.mark);
}

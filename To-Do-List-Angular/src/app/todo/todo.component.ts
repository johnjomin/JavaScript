import { Component, OnInit } from '@angular/core';
import { TodoService } from './shared/todo.service';



@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  //define array
  toDoListArray: any[];
  constructor(private toDoService: TodoService) { }

  ngOnInit(): void {
    this.toDoService.getToDoList().snapshotChanges().subscribe(item => {
      this.toDoListArray = [];
      item.forEach(element => {
        var x = element.payload.toJSON();
        x["$key"] = element.keyl
        this.toDoListArray.push(x);
      })

      //sort array after checking the to do list -> being true
      this.toDoListArray.sort((a,b) =>{
        return a.isChecked - b.isChecked;
      })
    });
  }

  onAdd(itemTitle){
    this.toDoService.addTitle(itemTitle.value);
    //once added now, setting as null for resets
    itemTitle.value = null;
  }

  alterCheck($key: string, isChecked){
    this.toDoService.checkOrUnCheckedTitle($key, !isChecked);
  }

  onDelete($key: string){
    this.toDoService.removeTitle($key);
  }
}

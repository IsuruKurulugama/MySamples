import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { HomeService } from './home.service';

@Component({
  selector: 'abe-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public user: User = new User();
  public userList = [];

  constructor(private homeService: HomeService) { }

  ngOnInit() {
    this.getUserList();
  }

  getUserList() {
    this.homeService.getUsers().subscribe(res => {
      console.log(res);
      this.userList = res;
    }, error => {
      console.log(error)
    });
  }

  saveUser(item) {
    console.log("save user", this.user);
    if (item.id == 0) {
      this.homeService.saveUser(item).subscribe(res => {
        this.getUserList();
      }, error => {
        console.log(error)
      });
    } else {
      this.homeService.updateUser(item).subscribe(res => {
        console.log("saveUser response", res);
        this.getUserList();
      }, error => {
        console.log(error)
      });
    }
  }

  deleteUser(item) {
    this.homeService.deleteUser(item.id).subscribe(res => {
      this.getUserList();
    }, error => {
      console.log(error)
    });

  }

  addUser() {
    this.userList.push(new User());
  }

}

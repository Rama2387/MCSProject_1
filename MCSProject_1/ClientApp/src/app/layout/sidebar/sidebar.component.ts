import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit{
  selectedOption: boolean = false;
  color = ''

  constructor(
   // private authenticationService: DbService,
    private router: Router
  ) { }


  ngOnInit(): void {
   // this.color = localStorage.getItem('selectedItemColor') || '';
  }
  logout(): void {
    //this.authenticationService.logout();
  }
  selectedItem(selectedItem: string): void {

    this.color = selectedItem;
    localStorage.setItem('selectedItemColor', this.color);
  }

}

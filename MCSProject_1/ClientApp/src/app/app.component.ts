import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  isSidebarOpen = true; // Initial state of the sidebar

  toggleSidebar() {
    this.isSidebarOpen = !this.isSidebarOpen;
  }
}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-claim-details',
  templateUrl: './claim-details.component.html',
  styleUrls: ['./claim-details.component.css']
})

export class ClaimDetailsComponent implements OnInit {

  ddTypes: ddTypes[] = [
   
    {value: 'Arizona', viewValue: 'Arizona'},
    {value: 'Illinois', viewValue: 'Illinois'},
  ];

  selectedOption: string = ''; 

  displayedColumns = ['position', 'name', 'weight', 'symbol','position1', 'name1', 'weight1', 'symbol1','position2', 'name2', 'weight2', 'symbol2','position3', 'name3', 'weight3', 'symbol3'];
  dataSource = ELEMENT_DATA;
  constructor() { }

  ngOnInit(): void {
  }

  onOptionSelectionChange(event: any): void {
    console.log('Selected Option:', this.selectedOption);
  }
 
}

interface ddTypes {
  value: string;
  viewValue: string;
}
export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne'},
];

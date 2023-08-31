import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DbService } from 'src/app/services/db.service';

@Component({
  selector: 'app-main-claim-info',
  templateUrl: './main-claim-info.component.html',
  styleUrls: ['./main-claim-info.component.css']
})
export class MainClaimInfoComponent implements OnInit {



  ddTypes: ddTypes[] = [
    {value: 'Header', viewValue: '1500 Header'},
    {value: 'Details', viewValue: '1500 Detail'},
    {value: 'Arizona', viewValue: 'Arizona'},
    {value: 'Illinois', viewValue: 'Illinois'},
  ];

  selectedOption: string = ''; 

  todays_date: Date = new Date()
  formSubmitted : boolean = false
  claimSearchForm!: FormGroup
  claimId ! : number
  constructor(private dbService : DbService,private _fb : FormBuilder) { }

  ngOnInit() {
    this.claimSearchForm = this._fb.group({
      claimId : ['', Validators.required]
    })
    // this.dbService.getAllSunClaimEntityRef().subscribe(
    //   (val: any) => {
    //     console.log(val)
    //   },
    //   (err: any) => {
    //     console.log(err)
    //   }
    // )
  }

  passClaimIdToChild_MoreClaimInfo() {
    this.formSubmitted = true

    if (this.claimSearchForm.valid) {
      this.claimId = this.claimSearchForm.get('claimId')?.value;
      console.log(this.claimSearchForm.value)

    }

  }


  onOptionSelectionChange(event: any): void {
    console.log('Selected Option:', this.selectedOption);
  }
}

interface ddTypes {
  value: string;
  viewValue: string;
}
import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { FestApiService } from 'src/app/services/fest-api.service';
import { FestItemsService } from 'src/app/services/fest-items.service';

@Component({
  selector: 'app-fest-input',
  templateUrl: './fest-input.component.html',
  styleUrls: ['./fest-input.component.scss']
})
export class FestInputComponent implements OnInit {

  constructor(
    private _service: FestApiService,
    private _itemService: FestItemsService,
    private _snackBar: MatSnackBar
  ) { }

  ngOnInit(): void {
  }

  zipCode: string = '';
  units: string = 'metric';
  
  getWeather() {
    this._service.getWeather(this.zipCode, this.units).subscribe(
    data => {
      this._itemService.addItem(data);
    }, 
    error => {
        this._snackBar.open(error.message, 'Close', {
          duration: 2000,
        });
    });
  }

}

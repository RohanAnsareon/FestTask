import { Component, OnInit } from '@angular/core';
import { FestItemsService } from 'src/app/services/fest-items.service';

@Component({
  selector: 'app-fest-content',
  templateUrl: './fest-content.component.html',
  styleUrls: ['./fest-content.component.scss']
})
export class FestContentComponent implements OnInit {

  constructor(public _itemService: FestItemsService) { }
  
  ngOnInit(): void {
    this._itemService.initializeItems();
  }

}

import { Component, Input, OnInit } from '@angular/core';
import { FestCardItem } from 'src/app/models/fest-card-item';

@Component({
  selector: 'app-fest-content-item',
  templateUrl: './fest-content-item.component.html',
  styleUrls: ['./fest-content-item.component.scss']
})
export class FestContentItemComponent implements OnInit {

  @Input() item: FestCardItem;

  constructor() { }

  ngOnInit(): void {
  }

}

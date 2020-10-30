import { Injectable } from '@angular/core';
import { FestCardItem } from '../models/fest-card-item';

@Injectable({
  providedIn: 'root'
})
export class FestItemsService {

  constructor() { }

  public items: FestCardItem[] = [];

  addItem(item: FestCardItem) {
    this.items.push(item);
    localStorage.setItem('items', JSON.stringify(this.items));
  }

  initializeItems() {
    if (localStorage.getItem('items'))
      this.items = JSON.parse(localStorage.getItem('items'));
  }
}

import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-fest-navbar',
  templateUrl: './fest-navbar.component.html',
  styleUrls: ['./fest-navbar.component.scss']
})
export class FestNavbarComponent implements OnInit {

  constructor() { }

  @Input() title: string

  ngOnInit(): void {
  }

}

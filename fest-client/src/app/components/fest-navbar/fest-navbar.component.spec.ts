import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FestNavbarComponent } from './fest-navbar.component';

describe('FestNavbarComponent', () => {
  let component: FestNavbarComponent;
  let fixture: ComponentFixture<FestNavbarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FestNavbarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FestNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

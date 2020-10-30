import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FestInputComponent } from './fest-input.component';

describe('FestInputComponent', () => {
  let component: FestInputComponent;
  let fixture: ComponentFixture<FestInputComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FestInputComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FestInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

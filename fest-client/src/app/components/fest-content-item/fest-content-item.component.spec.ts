import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FestContentItemComponent } from './fest-content-item.component';

describe('FestContentItemComponent', () => {
  let component: FestContentItemComponent;
  let fixture: ComponentFixture<FestContentItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FestContentItemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FestContentItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

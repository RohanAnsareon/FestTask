import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FestContentComponent } from './fest-content.component';

describe('FestContentComponent', () => {
  let component: FestContentComponent;
  let fixture: ComponentFixture<FestContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FestContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FestContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

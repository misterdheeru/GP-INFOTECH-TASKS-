import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RectiveformsComponent } from './rectiveforms.component';

describe('RectiveformsComponent', () => {
  let component: RectiveformsComponent;
  let fixture: ComponentFixture<RectiveformsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RectiveformsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RectiveformsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GpImgComponent } from './gp-img.component';

describe('GpImgComponent', () => {
  let component: GpImgComponent;
  let fixture: ComponentFixture<GpImgComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GpImgComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(GpImgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

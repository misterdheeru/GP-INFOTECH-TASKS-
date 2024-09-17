import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormsBulderComponent } from './forms-bulder.component';

describe('FormsBulderComponent', () => {
  let component: FormsBulderComponent;
  let fixture: ComponentFixture<FormsBulderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FormsBulderComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FormsBulderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

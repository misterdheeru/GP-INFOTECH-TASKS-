import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataBindingExamplesComponent } from './data-binding-examples.component';

describe('DataBindingExamplesComponent', () => {
  let component: DataBindingExamplesComponent;
  let fixture: ComponentFixture<DataBindingExamplesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DataBindingExamplesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DataBindingExamplesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentCommunication1Component } from './component-communication-1.component';

describe('ComponentCommunication1Component', () => {
  let component: ComponentCommunication1Component;
  let fixture: ComponentFixture<ComponentCommunication1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComponentCommunication1Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ComponentCommunication1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

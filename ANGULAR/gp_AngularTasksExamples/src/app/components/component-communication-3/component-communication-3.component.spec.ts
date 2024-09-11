import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentCommunication3Component } from './component-communication-3.component';

describe('ComponentCommunication3Component', () => {
  let component: ComponentCommunication3Component;
  let fixture: ComponentFixture<ComponentCommunication3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComponentCommunication3Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ComponentCommunication3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentCommunicationParrentComponent } from './component-communication-parrent.component';

describe('ComponentCommunicationParrentComponent', () => {
  let component: ComponentCommunicationParrentComponent;
  let fixture: ComponentFixture<ComponentCommunicationParrentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComponentCommunicationParrentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ComponentCommunicationParrentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

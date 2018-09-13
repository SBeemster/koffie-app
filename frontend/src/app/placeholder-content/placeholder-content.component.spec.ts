import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlaceholderContentComponent } from './placeholder-content.component';

describe('PlaceholderContentComponent', () => {
  let component: PlaceholderContentComponent;
  let fixture: ComponentFixture<PlaceholderContentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlaceholderContentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlaceholderContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

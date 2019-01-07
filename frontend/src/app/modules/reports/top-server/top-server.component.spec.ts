import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopServerComponent } from './top-server.component';

describe('TopServerComponent', () => {
  let component: TopServerComponent;
  let fixture: ComponentFixture<TopServerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopServerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopServerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

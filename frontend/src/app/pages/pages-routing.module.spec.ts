import { PagesRoutingModule } from './pages-routing.module';

describe('PagesRoutingModule', () => {
  let pagesRoutingModule: PagesRoutingModule;

  beforeEach(() => {
    pagesRoutingModule = new PagesRoutingModule();
  });

  it('should create an instance', () => {
    expect(pagesRoutingModule).toBeTruthy();
  });
});

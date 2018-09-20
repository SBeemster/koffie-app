import { PagesRouterModule } from './pages-router.module';

describe('PagesRouterModule', () => {
  let pagesRouterModule: PagesRouterModule;

  beforeEach(() => {
    pagesRouterModule = new PagesRouterModule();
  });

  it('should create an instance', () => {
    expect(pagesRouterModule).toBeTruthy();
  });
});

import { Civitas.WebPage } from './app.po';

describe('civitas.web App', function() {
  let page: Civitas.WebPage;

  beforeEach(() => {
    page = new Civitas.WebPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

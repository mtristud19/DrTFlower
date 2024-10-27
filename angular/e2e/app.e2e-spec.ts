import { DrTFlowerTemplatePage } from './app.po';

describe('DrTFlower App', function() {
  let page: DrTFlowerTemplatePage;

  beforeEach(() => {
    page = new DrTFlowerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

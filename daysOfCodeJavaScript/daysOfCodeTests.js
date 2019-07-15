let should = chai.should();

describe('daysOfCode', () => {
    describe('SwapEnds', () => {
        it('should yield [4, 2, 3, 1] when given [1, 2, 3, 4]', () => {
            swapEnds([1, 2, 3, 4]).should.deep.equal([4, 2, 3, 1]);
        });
        it('should yield [3, 2, 1] when given [1, 2, 3]', () => {
            swapEnds([1, 2, 3]).should.deep.equal([3, 2, 1]);
        });
        it('should yield [8, 6, 7, 9, 5] when given [5, 6, 7, 9, 8]', () => {
            swapEnds([5, 6, 7, 9, 8]).should.deep.equal([8, 6, 7, 9, 5]);
        });
    });

    describe('Has12', () => {
        it('should be true when given [1, 3, 2]', () => {
            has12([1, 3, 2]).should.be.true;
        });
        it('should be false when given [3, 2, 1]', () => {
            has12([3, 2, 1]).should.be.false;
        });
        it('should be true when given [3, 1, 4, 2, 5]', () => {
            has12([3, 1, 4, 2, 5]).should.be.true;
        });
    });

    describe('GreenTicket', () => {
        it('should yield 0 when given (1, 2, 3)', () => {
            greenTicket(1, 2, 3).should.equal(0);
        });
        it('should yield 20 when given (2, 2, 2)', () => {
            greenTicket(2, 2, 2).should.equal(20);
        });
        it('should yield 10 when given (1, 1, 2)', () => {
            greenTicket(1, 1, 2).should.equal(10);
        });
    });

    
    describe('Start1', () => {
        it('should yield 2 when given ([1, 2, 3], [1, 3])', () => {
            start1([1, 2, 3], [1, 3]).should.equal(2);
        });
        it('should yield 1 when given ([7, 2, 3], [1])', () => {
            start1([7, 2, 3], [1]).should.equal(1);
        });
        it('should yield 1 when given ([1, 2], [])', () => {
            start1([1, 2], []).should.equal(1);
        });
        it('should yield 0 when given ([2, 1], [4, 6, 8, 10])', () => {
            start1([2, 1], [4, 6, 8, 10]).should.equal(0);
        });
    });
    
    describe('FizzArray3', () => {
        it('should yield [5, 6, 7, 8, 9] when given (5, 10)', () => {
            fizzArray3(5, 10).should.deep.equal([5, 6, 7, 8, 9]);
        });
        it('should yield [11, 12, 13, 14, 15, 16, 17] when given (11, 18)', () => {
            fizzArray3(11, 18).should.deep.equal([11, 12, 13, 14, 15, 16, 17]);
        });
        it('should yield [1, 2] when given (1, 3)', () => {
            fizzArray3(1, 3).should.deep.equal([1, 2]);
        });
        it('should yield [] when given (5, 5)', () => {
            fizzArray3(5, 5).should.deep.equal([]);
        });
    });

    describe('Only14', () => {
        it('should be true when given [1, 4, 1, 4]', () => {
            only14([1, 4, 1, 4]).should.be.true;
        });
        it('should be false when given [1, 4, 2, 4]', () => {
            only14([1, 4, 2, 4]).should.be.false;
        });
        it('should be true when given [1, 1]', () => {
            only14([1, 1]).should.be.true;
        });
    });
});